using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.MyModels
{
    public class CitizenTestResults
    {
        public int Id { get; set; }
        public int NumberTicket { get; set; }
        [Required(ErrorMessage = "Լրացրեք մարզը")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Լրացրեք համայնքը")]
        public string Community { get; set; }
        [Required(ErrorMessage = "Լրացրեք ընտրական տարածքը")]
        public int CEC { get; set; }
        [Required(ErrorMessage = "Լրացրեք ընտրական տեղամասը")]
        public string TEC { get; set; }
        [Required(ErrorMessage = "Լրացրեք Մասնակիցների թիվը")]
        public int Participants { get; set; }
        [Required(ErrorMessage = "Լրացրեք Քվեարկության օրն ընտրական տեղամասում կազմված ընտրողների լրացուցիչ ցուցակում Ընտրողների թիվը")]
        public int AllAdditionallyDuringElDay { get; set; }
        [Required(ErrorMessage = "Լրացրեք Քվեարկության օրն ընտրական տեղամասում կազմված ընտրողների լրացուցիչ ցուցակում Մասնակիցների թիվը")]
        public int PartAdditionallyDuringElDay { get; set; }
        [Required(ErrorMessage = "Լրացրեք Շրջիկ արկղով քվեարկողների Ընտրողների թիվը")]
        public int AllMobileVoters { get; set; }
        [Required(ErrorMessage = "Լրացրեք Շրջիկ արկղով քվեարկողների Մասնակիցների թիվը")]
        public int PartMobileVoters { get; set; }
        [Required(ErrorMessage = "Լրացրեք Ընդհանուր թիվը 1-ին, 2-րդ, 3-րդ տողերի գումարը` Ընտրողների թիվը")]
        public int AllSum { get; set; }
        [Required(ErrorMessage = "Լրացրեք Ընդհանուր թիվը 1-ին, 2-րդ, 3-րդ տողերի գումարը` Մասնակիցների թիվը")]
        public int PartSum { get; set; }
        [Required(ErrorMessage = "Լրացրեք Ընտրողներից ստացված տեխնիկական սարքավորմամբ տպված կտրոնների թիվը")]
        public int VadTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք Ընտրողներից ստացված համարակալված քվեարկության կտրոնների թիվը")]
        public int NumerableTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք Ընտրողներից ստացված կտրոնների ընդհանուր թիվը")]
        public int AllTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք Չօգտագործված համարակալված կտրոնների թիվը")]
        public int UnusedNumerableTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք Չօգտագործված ինքնասոսնձվող դրոշմանիշների թիվը")]
        public int UnusedGlueTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք Անվավեր քվեաթերթիկների թիվը")]
        public int InvalidTickets { get; set; }
        [Required(ErrorMessage = "Լրացրեք A  Կուսակցության, կուսակցությունների դաշինքի կողմ քվեարկված քվեաթերթիկների թիվը")]
        public int ForA { get; set; }
        [Required(ErrorMessage = "Լրացրեք B Կուսակցության, կուսակցությունների դաշինքի կողմ քվեարկված քվեաթերթիկների թիվը ")]
        public int ForB { get; set; }
        [Required(ErrorMessage = "Լրացրեք C Կուսակցության, կուսակցությունների դաշինքի կողմ քվեարկված քվեաթերթիկների թիվը ")]
        public int ForC { get; set; }
        [Required(ErrorMessage = "Լրացրեք A կուսակցության տարածքային ընտրական ցուցակում ընդգրկված X թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը")]
        public int ForAx { get; set; }
        [Required(ErrorMessage = "Լրացրեք A կուսակցության տարածքային ընտրական ցուցակում ընդգրկված Y թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը ")]
        public int ForAy { get; set; }
        [Required(ErrorMessage = "Լրացրեք B կուսակցության տարածքային ընտրական ցուցակում ընդգրկված M թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը")]
        public int ForBm { get; set; }
        [Required(ErrorMessage = "Լրացրեք B կուսակցության տարածքային ընտրական ցուցակում ընդգրկված N թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը ")]
        public int ForBn { get; set; }
        [Required(ErrorMessage = "Լրացրեք C կուսակցության տարածքային ընտրական ցուցակում ընդգրկված K թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը")]
        public int ForCk { get; set; }
        [Required(ErrorMessage = "Լրացրեք C կուսակցության տարածքային ընտրական ցուցակում ընդգրկված L թեկնածուի կողմ քվեարկված քվեաթերթիկների թիվը ")]
        public int ForCl { get; set; }
        public double Result { get; set; }
    }
}
