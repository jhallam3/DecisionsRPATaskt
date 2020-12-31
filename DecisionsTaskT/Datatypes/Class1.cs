using System;

namespace DecisionsTaskT.Datatypes
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Script
    {

        private ScriptScriptAction[] commandsField;

        private ScriptVariables variablesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ScriptAction", IsNullable = false)]
        public ScriptScriptAction[] Commands
        {
            get
            {
                return this.commandsField;
            }
            set
            {
                this.commandsField = value;
            }
        }

        /// <remarks/>
        public ScriptVariables Variables
        {
            get
            {
                return this.variablesField;
            }
            set
            {
                this.variablesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScriptScriptAction
    {

        private ScriptScriptActionScriptCommand scriptCommandField;

        /// <remarks/>
        public ScriptScriptActionScriptCommand ScriptCommand
        {
            get
            {
                return this.scriptCommandField;
            }
            set
            {
                this.scriptCommandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScriptScriptActionScriptCommand
    {

        private string commandIDField;

        private string commandNameField;

        private bool isCommentedField;

        private string selectionNameField;

        private byte defaultPauseField;

        private byte lineNumberField;

        private bool pauseBeforeExeucutionField;

        private bool commandEnabledField;

        private string v_userVariableNameField;

        private string v_InputField;

        private string v_ProgramNameField;

        private string v_ProgramArgsField;

        private string v_WaitForExitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommandID
        {
            get
            {
                return this.commandIDField;
            }
            set
            {
                this.commandIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommandName
        {
            get
            {
                return this.commandNameField;
            }
            set
            {
                this.commandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsCommented
        {
            get
            {
                return this.isCommentedField;
            }
            set
            {
                this.isCommentedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectionName
        {
            get
            {
                return this.selectionNameField;
            }
            set
            {
                this.selectionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DefaultPause
        {
            get
            {
                return this.defaultPauseField;
            }
            set
            {
                this.defaultPauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PauseBeforeExeucution
        {
            get
            {
                return this.pauseBeforeExeucutionField;
            }
            set
            {
                this.pauseBeforeExeucutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CommandEnabled
        {
            get
            {
                return this.commandEnabledField;
            }
            set
            {
                this.commandEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v_userVariableName
        {
            get
            {
                return this.v_userVariableNameField;
            }
            set
            {
                this.v_userVariableNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v_Input
        {
            get
            {
                return this.v_InputField;
            }
            set
            {
                this.v_InputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v_ProgramName
        {
            get
            {
                return this.v_ProgramNameField;
            }
            set
            {
                this.v_ProgramNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v_ProgramArgs
        {
            get
            {
                return this.v_ProgramArgsField;
            }
            set
            {
                this.v_ProgramArgsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string v_WaitForExit
        {
            get
            {
                return this.v_WaitForExitField;
            }
            set
            {
                this.v_WaitForExitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScriptVariables
    {

        private ScriptVariablesScriptVariable scriptVariableField;

        /// <remarks/>
        public ScriptVariablesScriptVariable ScriptVariable
        {
            get
            {
                return this.scriptVariableField;
            }
            set
            {
                this.scriptVariableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ScriptVariablesScriptVariable
    {

        private string variableNameField;

        private string variableValueField;

        /// <remarks/>
        public string VariableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
            }
        }

        /// <remarks/>
        public string VariableValue
        {
            get
            {
                return this.variableValueField;
            }
            set
            {
                this.variableValueField = value;
            }
        }
    }


}
