using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFlow.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id {get; set; }
    
    [Required(ErrorMessage = "Título Inválido")]
    [MaxLength(80, ErrorMessage = "o Título deve conter até 80 caracteres")]
    public string Title {get; set;} = string.Empty;

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description {get; set;} = string.Empty;
        
}
