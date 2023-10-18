// Copyright (c) Microsoft. All rights reserved.
using YamlDotNet.Serialization;

namespace Microsoft.SemanticKernel;

internal sealed class AIFunctionModel
{
    [YamlMember(Alias = "name")]
    public string Name { get; set; }

    [YamlMember(Alias = "template")]
    public string Template { get; set; }

    [YamlMember(Alias = "template_format")]
    public string TemplateFormat { get; set; }

    [YamlMember(Alias = "description")]
    public string Description { get; set; }


    [YamlMember(Alias = "input_variables")]
    public List<SKVariableView> InputVariables { get; set; }

    [YamlMember(Alias = "output_variable")]
    public SKVariableView OutputVariable { get; set; }

    [YamlMember(Alias = "models")]
    public Dictionary<string, Dictionary<string, object>> Models { get; set; }
}

public class SKVariableView
{
    [YamlMember(Alias = "name")]
    public string Name { get; set;   }

    [YamlMember(Alias = "type")]
    public string Type { get; set;  }

    [YamlMember(Alias = "description")]
    public string Description { get; set;  }

    [YamlMember(Alias = "default_value")]
    public dynamic DefaultValue { get; set;   }

    [YamlMember(Alias = "is_required")]
    public bool IsRequired { get; set;  }
}
