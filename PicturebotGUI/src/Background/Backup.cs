﻿using Picturebot;
using Picturebot.src.POCO;
using PicturebotGUI.src.Enums;
using PicturebotGUI.src.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturebotGUI.src.Background
{
    public class Backup : BaseBackground
    {
        private string _shootInfo = string.Empty;
        public Backup(BackgroundWorker backgroundWorker, Config config, FormLoading formLoading, string shootInfo)
        {
            BackgroundWorker = backgroundWorker;
            Config = config;
            FormLoading = formLoading;
            _shootInfo = shootInfo;
        }

        public override void Work()
        {
            int index = 1;

            try
            {
                string path = Path.Combine(Config.Workspace, _shootInfo, Workflow.Baseflow);
                Guard.Filesystem.PathExist(path);

                int count = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Length;

                string[] files = Directory.GetFiles(path).OrderByDescending(d => new FileInfo(d).LastWriteTime).ToArray(); ;

                foreach (var file in files)
                {
                    if (!BackgroundWorker.CancellationPending)
                    {
                        Picture picture = new Picture(file, Config.Workspace);
                        string dst = Path.Combine(Config.Workspace, _shootInfo, Workflow.Backup, picture.FilenameExtension);

                        int procent = index++ * 100 / count;
                        BackgroundWorker.ReportProgress(procent, $"Backup: {index - 1}/{count}");

                        string f = $"{index - 1} {file}";

                        File.Copy(picture.Absolute, dst);
                    }
                }
            }

            catch (Exception)
            {
                BackgroundWorker.CancelAsync();
            }
        }
    }
}
