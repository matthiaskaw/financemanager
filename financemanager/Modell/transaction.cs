using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using financemanager.Datatypes;

namespace financemanager.Modell
{

    [Table("VRTransaction")]
    public class VRTransaction
    {

        


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int VRTransactionID { get; set; }

        [Column("order account")]
        public string OrderAccount { get; set; }

        [Required]
        [MaxLength(22)]
        [Column("iban client")]
        public string IBANClient { get; set; }

        [Required]
        [MaxLength(11)]
        [Column("bic client")]
        public string BICClient { get; set; }

        [Column("client account")]
        public string ClientAccount { get; set; }


        [Required]
        [MaxLength(10)]
        [Column("bookin date")]
        public string BookingDate { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("value date")]
        public string ValueDate { get; set; }

        [Required]
        [Column("name payee")]
        public string PayeeName { get; set; }

        [Required]
        [MaxLength(22)]
        [Column("payee IBAN")]
        public string PayeeIBAN { get; set; }

        [Required]
        [MaxLength(11)]
        [Column("payee BIC")]
        public string PayeeBIC { get; set; }

        [Required]
        [Column("booking text")]
        public string BookingText { get; set; }

        [Required]
        [Column("purpose of use")]
        public string PurposeofUse { get; set; }

        [Required]
        [Column("amount")]
        public string Amount { get; set; }

        [Required]
        [Column("saldo after booking")]
        public string SaldoAfterBooking { get; set; }


        [Column("note")]
        public string Note { get; set; }


        [Column("category")]
        public string Category { get; set; }

        [Column("tax relevant")]
        public string TaxRelevant { get; set; }


        [Required]
        [Column("creditor id")]
        [ForeignKey("Creditor")]
        public string CreditorID { get; set; }

        [Column("mandate reference")]
        public string MandateReference { get; set; }

        private List<string> columns = new List<string>();
        private void fillList() {

            columns.Add(OrderAccount);
            columns.Add(IBANClient);
            columns.Add(BICClient);
            columns.Add(ClientAccount);
            columns.Add(BookingDate);
            columns.Add(ValueDate);
            columns.Add(PayeeName);
            columns.Add(PayeeIBAN);
            columns.Add(PayeeBIC);
            columns.Add(ValueDate);
            columns.Add(PayeeName);
            columns.Add(PayeeIBAN);
            columns.Add(PayeeBIC);
            columns.Add(BookingText);
            columns.Add(PurposeofUse);
            columns.Add(Amount);
            columns.Add(SaldoAfterBooking);
            columns.Add(Note);
            columns.Add(Category); 
            columns.Add(TaxRelevant);
            columns.Add(CreditorID);
            columns.Add(MandateReference);
        }
        
    }  
}