﻿//
// https://github.com/Dirkster99/AvalonDock/blob/5032524bae6e342dbb648a4c1d3fc3264f449db9/source/MLibTest/MLibTest/Demos/ViewModels/WorkSpaceViewModel.cs
// 

using Catel.Services;
using WolvenKit.App.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel.MVVM;
using WolvenKit.App.Commands;
using Catel;
using Catel.IoC;
using Orc.ProjectManagement;
using WolvenKit.App.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
	/// The WorkSpaceViewModel implements AvalonDock demo specific properties, events and methods.
	/// </summary>
	public class WorkSpaceViewModel : ViewModelBase, IWorkSpaceViewModel
	{
		#region fields
		private readonly ObservableCollection<DocumentViewModel> _files = new ObservableCollection<DocumentViewModel>();
		private ToolViewModel[] _tools = null;

		private ICommand _openCommand = null;
		private ICommand _newCommand = null;
        

        


		private LogViewModel _logViewModel = null;
		private ProjectExplorerViewModel _projectExplorerViewModel = null;




		private DocumentViewModel _activeDocument = null;

		private int _newDocumentCounter = 0;

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;



		#endregion fields

		#region constructors
		/// <summary>
		/// Class constructor
		/// </summary>
		public WorkSpaceViewModel(
            IProjectManager projectManager,
			ILoggerService loggerService,
			IMessageService messageService, 
            ICommandManager commandManager)
		{
            Argument.IsNotNull(() => projectManager);
			Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
			_loggerService = loggerService;
			_messageService = messageService;

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);

			// register as application-wide commands
            commandManager.RegisterCommand(nameof(AppCommands.Application.ShowLog), ShowLogCommand, this);
            commandManager.RegisterCommand(nameof(AppCommands.Application.ShowProjectExplorer), ShowProjectExplorerCommand, this);
			commandManager.RegisterCommand(nameof(AppCommands.Application.ShowImportUtility), ShowImportUtilityCommand, this);

		}
		#endregion constructors

		#region init
		protected override async Task InitializeAsync()
		{
            _projectManager.ProjectActivationAsync += OnProjectActivationAsync;

			await base.InitializeAsync();
        }

        protected override Task OnClosingAsync()
        {
            _projectManager.ProjectActivationAsync -= OnProjectActivationAsync;
			RaisePropertyChanged(nameof(SaveLayout));

			return base.OnClosingAsync();
        }

        protected override Task CloseAsync()
		{
			// TODO: Unsubscribe from events
            

			return base.CloseAsync();
		}
		#endregion

		#region commands
        public ICommand ShowLogCommand { get; private set; }
		private bool CanShowLog() => true;
        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

        public ICommand ShowProjectExplorerCommand { get; private set; }
        private bool CanShowProjectExplorer() => true;
        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

		public ICommand ShowImportUtilityCommand { get; private set; }
        private bool CanShowImportUtility() => true;
        private void ExecuteShowImportUtility()
        {
			// TODO: Handle command logic here


		}


		#endregion


		/// <summary>
		/// Event is raised when AvalonDock (or the user) selects a new document.
		/// </summary>
		public event EventHandler ActiveDocumentChanged;

		#region Properties
        public Project Project { get; set; }

		public bool SaveLayout { get; set; }

		/// <summary>
		/// Gets/Sets the currently active document.
		/// </summary>
		public DocumentViewModel ActiveDocument
		{
			get => _activeDocument;
			set             // This can also be set by the user via the view
			{
				if (_activeDocument != value)
				{
					_activeDocument = value;
					RaisePropertyChanged(nameof(ActiveDocument));

                    ActiveDocumentChanged?.Invoke(this, EventArgs.Empty);
                }
			}
		}

		/// <summary>
		/// Gets a collection of all currently available document viewmodels
		/// </summary>
		public IEnumerable<DocumentViewModel> Files => _files;

		/// <summary>
		/// Gets an enumeration of all currently available tool window viewmodels.
		/// </summary>
		public IEnumerable<ToolViewModel> Tools => _tools ?? (_tools = new ToolViewModel[] { Log });

        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
		public void CloseAllDocuments()
		{
			ActiveDocument = null;
			_files.Clear();
		}

		/// <summary>
		/// Gets an instance of the LogViewModel.
		/// </summary>
		public LogViewModel Log => _logViewModel ?? (_logViewModel = new LogViewModel());

        /// <summary>
        /// Gets an instance of the LogViewModel.
        /// </summary>
        public ProjectExplorerViewModel ProjectExplorer => _projectExplorerViewModel ?? (_projectExplorerViewModel = new ProjectExplorerViewModel());

		/// <summary>
		/// Gets a open document command to open files from the file system.
		/// </summary>
		public ICommand OpenCommand =>
            _openCommand ?? (_openCommand =
                new DelegateCommand<object>(async (p) => await OnOpenAsync(p), (p) => CanOpen(p)));

        /// <summary>
        /// Gets a new document command to create new documents from scratch.
        /// </summary>
        public ICommand NewCommand =>
            _newCommand ?? (_newCommand = new DelegateCommand<object>((p) => OnNew(p), (p) => CanNew(p)));

		#endregion Properties

		#region methods
		private async Task OnProjectActivationAsync(object sender, ProjectUpdatingCancelEventArgs e)
        {
            var newProject = (Project)e.NewProject;
            if (newProject is null)
            {
                return;
            }

            Project = newProject;

            
        }
		/// <summary>
		/// Checks if a document can be closed and asks the user whether
		/// to save before closing if the document appears to be dirty.
		/// </summary>
		/// <param name="fileToClose"></param>
		public void Close(DocumentViewModel fileToClose)
		{
			if (fileToClose.IsDirty)
			{
				var res = MessageBox.Show(string.Format("Save changes for file '{0}'?", fileToClose.FileName), "AvalonDock Test App", MessageBoxButton.YesNoCancel);
				if (res == MessageBoxResult.Cancel)
					return;

				if (res == MessageBoxResult.Yes)
				{
					Save(fileToClose);
				}
			}

			_files.Remove(fileToClose);
		}

		/// <summary>
		/// Add a new document viewmodel into the collection of files.
		/// </summary>
		/// <param name="fileToAdd"></param>
		public void AddFile(DocumentViewModel fileToAdd)
		{
			if (fileToAdd == null) return;

			// Don't add this twice
			if (_files.Any(f => f.ContentId == fileToAdd.ContentId))
				return;

			_files.Add(fileToAdd);
		}

		/// <summary>
		/// Saves a document and resets the dirty flag.
		/// </summary>
		/// <param name="fileToSave"></param>
		/// <param name="saveAsFlag"></param>
		public void Save(DocumentViewModel fileToSave, bool saveAsFlag = false)
		{
			if (fileToSave.FilePath == null || saveAsFlag)
			{
				var dlg = new SaveFileDialog();
				if (dlg.ShowDialog().GetValueOrDefault())
					fileToSave.FilePath = dlg.SafeFileName;
			}

			System.IO.File.WriteAllText(fileToSave.FilePath, fileToSave.TextContent);
			ActiveDocument.IsDirty = false;
		}

		#region OpenCommand
		/// <summary>
		/// Determines if application can currently open a document or not.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		private bool CanOpen(object parameter)
		{
			return true;
		}

		private async Task OnOpenAsync(object parameter)
		{
			var dlg = new OpenFileDialog();
			if (dlg.ShowDialog().GetValueOrDefault())
			{
				var fileViewModel = await OpenAsync(dlg.FileName);
				ActiveDocument = fileViewModel;
			}
		}

		/// <summary>
		/// Open a file and return its content in a viewmodel.
		/// </summary>
		/// <param name="filepath"></param>
		/// <returns></returns>
		public async Task<DocumentViewModel> OpenAsync(string filepath)
		{
			// Check if we have already loaded this file and return it if so
			var fileViewModel = _files.FirstOrDefault(fm => fm.FilePath == filepath);
			if (fileViewModel != null)
				return fileViewModel;

			fileViewModel = new DocumentViewModel(this as IWorkSpaceViewModel, filepath, true);
			bool result = await fileViewModel.OpenFileAsync(filepath);

			if (result)
			{
				_files.Add(fileViewModel);
				return fileViewModel;
			}

			return null;
		}
		#endregion  OpenCommand

		#region NewCommand
		/// <summary>
		/// Determines if application can currently create a new document or not.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		private bool CanNew(object parameter)
		{
			return true;
		}

		private void OnNew(object parameter)
		{
			string path = string.Format("Untitled{0}.txt", _newDocumentCounter++);

			var newFile = new DocumentViewModel(this as IWorkSpaceViewModel, path, false);
			_files.Add(newFile);
			ActiveDocument = newFile;
		}

		#endregion
		#endregion methods
	}
}
