﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склад.
    /// </summary>
    // *** Start programmer edit section *** (склад CustomAttributes)

    // *** End programmer edit section *** (склад CustomAttributes)
    [AutoAltered()]
    [Caption("Склад")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("складE", new string[] {
            "номер as \'Номер\'",
            "адрес as \'Адрес\'",
            "кладовщик as \'Кладовщик\'",
            "кладовщик.фамилия as \'Фамилия\'"})]
    [AssociatedDetailViewAttribute("складE", "ТоварНаСкладе", "ТоварНаСкладеE", true, "", "Товар на складе", true, new string[] {
            ""})]
    [View("складL", new string[] {
            "номер as \'Номер\'",
            "адрес as \'Адрес\'",
            "кладовщик.фамилия as \'Фамилия\'"})]
    public class склад : ICSSoft.STORMNET.DataObject
    {
        
        private int fномер;
        
        private string fадрес;
        
        private IIS.АСУ_склад.Сотрудник fкладовщик;
        
        private IIS.АСУ_склад.DetailArrayOfТоварНаСкладе fТоварНаСкладе;
        
        // *** Start programmer edit section *** (склад CustomMembers)

        // *** End programmer edit section *** (склад CustomMembers)

        
        /// <summary>
        /// номер.
        /// </summary>
        // *** Start programmer edit section *** (склад.номер CustomAttributes)

        // *** End programmer edit section *** (склад.номер CustomAttributes)
        public virtual int номер
        {
            get
            {
                // *** Start programmer edit section *** (склад.номер Get start)

                // *** End programmer edit section *** (склад.номер Get start)
                int result = this.fномер;
                // *** Start programmer edit section *** (склад.номер Get end)

                // *** End programmer edit section *** (склад.номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (склад.номер Set start)

                // *** End programmer edit section *** (склад.номер Set start)
                this.fномер = value;
                // *** Start programmer edit section *** (склад.номер Set end)

                // *** End programmer edit section *** (склад.номер Set end)
            }
        }
        
        /// <summary>
        /// адрес.
        /// </summary>
        // *** Start programmer edit section *** (склад.адрес CustomAttributes)

        // *** End programmer edit section *** (склад.адрес CustomAttributes)
        [StrLen(255)]
        public virtual string адрес
        {
            get
            {
                // *** Start programmer edit section *** (склад.адрес Get start)

                // *** End programmer edit section *** (склад.адрес Get start)
                string result = this.fадрес;
                // *** Start programmer edit section *** (склад.адрес Get end)

                // *** End programmer edit section *** (склад.адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (склад.адрес Set start)

                // *** End programmer edit section *** (склад.адрес Set start)
                this.fадрес = value;
                // *** Start programmer edit section *** (склад.адрес Set end)

                // *** End programmer edit section *** (склад.адрес Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (склад.кладовщик CustomAttributes)

        // *** End programmer edit section *** (склад.кладовщик CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_склад.Сотрудник кладовщик
        {
            get
            {
                // *** Start programmer edit section *** (склад.кладовщик Get start)

                // *** End programmer edit section *** (склад.кладовщик Get start)
                IIS.АСУ_склад.Сотрудник result = this.fкладовщик;
                // *** Start programmer edit section *** (склад.кладовщик Get end)

                // *** End programmer edit section *** (склад.кладовщик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (склад.кладовщик Set start)

                // *** End programmer edit section *** (склад.кладовщик Set start)
                this.fкладовщик = value;
                // *** Start programmer edit section *** (склад.кладовщик Set end)

                // *** End programmer edit section *** (склад.кладовщик Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (склад.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (склад.ТоварНаСкладе CustomAttributes)
        public virtual IIS.АСУ_склад.DetailArrayOfТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (склад.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (склад.ТоварНаСкладе Get start)
                if ((this.fТоварНаСкладе == null))
                {
                    this.fТоварНаСкладе = new IIS.АСУ_склад.DetailArrayOfТоварНаСкладе(this);
                }
                IIS.АСУ_склад.DetailArrayOfТоварНаСкладе result = this.fТоварНаСкладе;
                // *** Start programmer edit section *** (склад.ТоварНаСкладе Get end)

                // *** End programmer edit section *** (склад.ТоварНаСкладе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (склад.ТоварНаСкладе Set start)

                // *** End programmer edit section *** (склад.ТоварНаСкладе Set start)
                this.fТоварНаСкладе = value;
                // *** Start programmer edit section *** (склад.ТоварНаСкладе Set end)

                // *** End programmer edit section *** (склад.ТоварНаСкладе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "складE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View складE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("складE", typeof(IIS.АСУ_склад.склад));
                }
            }
            
            /// <summary>
            /// "складL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View складL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("складL", typeof(IIS.АСУ_склад.склад));
                }
            }
        }
    }
}
