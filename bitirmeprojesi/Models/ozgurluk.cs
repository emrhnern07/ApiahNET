//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitirmeprojesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ozgurluk
    {
        public int id { get; set; }
        public int mahalle_id { get; set; }
        public string pafta_no { get; set; }
        public Nullable<double> ada_no { get; set; }
        public Nullable<double> parsel_no { get; set; }
        public string ada_parsel { get; set; }
        public string alan_m2 { get; set; }
        public string alan { get; set; }
        public string plan_fonksiyon_adi { get; set; }
        public string insaat_nizami { get; set; }
        public string subasman_kotu { get; set; }
        public Nullable<int> kat_adedi_id { get; set; }
        public string sacak_seviyesi { get; set; }
        public string taks { get; set; }
        public string kaks { get; set; }
        public string emsal { get; set; }
        public string on_bahce { get; set; }
        public string yan_bahce1 { get; set; }
        public string yan_bahce2 { get; set; }
        public string arka_bahce { get; set; }
        public Nullable<double> insaat_cephesi { get; set; }
        public string insaat_derinligi { get; set; }
        public string ifraz_sarti { get; set; }
        public string aciklama1 { get; set; }
        public string aciklama2 { get; set; }
        public string aciklama3 { get; set; }
        public string parsel_durumu { get; set; }
    
        public virtual mahalleler mahalleler { get; set; }
        public virtual ozgurluk_katlar ozgurluk_katlar { get; set; }
        public double hesaplananAlan { get; internal set; }
    }
}
