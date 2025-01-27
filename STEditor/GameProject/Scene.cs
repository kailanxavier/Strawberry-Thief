using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace STEditor.GameProject
{
    [DataContract]
    public class Scene : ViewModelBase
    {
        private string _name;
        [DataMember] public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                { 
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        [DataMember] public Project Project { get; private set; }

        public Scene(Project project, string name)
        { 
            Debug.Assert(project != null);
            Project = project;
            Name = name;
        }
        // The serialization of these actually makes no fucking sense
        // and it will stop the project from being opened from other
        // machines. However I don't feel like rewriting it right now
        // so that will be a problem for future me.
    }
}
