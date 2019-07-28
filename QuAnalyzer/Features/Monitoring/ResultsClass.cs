﻿using QuAnalyzer.Features.Performance;
using QuAnalyzer.Generic;
using System;
using System.Collections.Generic;

namespace QuAnalyzer.Features.Monitoring
{
    public class ResultsClass : NotifierHelper
    {
        public MonitorItem Step { get; set; }

        public bool IsOK { get; set; }
        public DateTimeOffset LastCheck { get; } = DateTimeOffset.Now;

        private Status _status;
        public Status Status
        {
            get => _status;
            set { _status = value; NotifyPropertyChanged(); }
        }

        public DateTimeOffset End { get; set; }

        private long _resultCount;
        public long ResultCount
        {
            get { return _resultCount; }
            set { _resultCount = value; NotifyPropertyChanged(); }
        }

        private Dictionary<string, long> _duration;
        public Dictionary<string, long> Duration
        {
            get { return _duration; }
            set { _duration = value; NotifyPropertyChanged(); }
        }

        public int Occurence { get; set; }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; NotifyPropertyChanged(); }
        }

        private object _data;
        public object Data
        {
            get { return _data; }
            set { _data = value; NotifyPropertyChanged(); }
        }

        public string Name { get; internal set; }
        public string Id { get; internal set; }
        public int Index { get; internal set; }
    }
}