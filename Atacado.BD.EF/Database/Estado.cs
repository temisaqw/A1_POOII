namespace Atacado.BD.EF.Database;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Estado")]
public class Estado
{
    [Key]
    public Int64 CodigoEstado{get;set;}

    [Unicode(false)]
    public String Nome {get;set;} = null!;
    
    [Unicode(false)]
    public String UF {get;set;} = null!;

    public Int64 CodigoRegiao {get; set;}

    public Estado()
    {}
}
