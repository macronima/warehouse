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
    /// Записьвнакладной.
    /// </summary>
    // *** Start programmer edit section *** (записьвнакладной CustomAttributes)

    // *** End programmer edit section *** (записьвнакладной CustomAttributes)
    [AutoAltered()]
    [Caption("Записьвнакладной")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("записьвнакладнойE", new string[] {
            "количество as \'Количество\'",
            "вес as \'Вес\'",
            "цена as \'Цена\'",
            "сумма as \'Сумма\'",
            "Товар as \'Товар\'",
            "Товар.название as \'Название\'"}, Hidden=new string[] {
            "Товар.название"})]
    [MasterViewDefineAttribute("записьвнакладнойE", "Товар", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "название")]
    public class записьвнакладной : ICSSoft.STORMNET.DataObject
    {
        
        private int fколичество;
        
        private double fвес;
        
        private double fцена;
        
        private double fсумма;
        
        private IIS.АСУ_склад.Товар fТовар;
        
        private IIS.АСУ_склад.накладная fнакладная;
        
        // *** Start programmer edit section *** (записьвнакладной CustomMembers)

        // *** End programmer edit section *** (записьвнакладной CustomMembers)

        
        /// <summary>
        /// количество.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.количество CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.количество CustomAttributes)
        public virtual int количество
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.количество Get start)

                // *** End programmer edit section *** (записьвнакладной.количество Get start)
                int result = this.fколичество;
                // *** Start programmer edit section *** (записьвнакладной.количество Get end)

                // *** End programmer edit section *** (записьвнакладной.количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.количество Set start)

                // *** End programmer edit section *** (записьвнакладной.количество Set start)
                this.fколичество = value;
                // *** Start programmer edit section *** (записьвнакладной.количество Set end)

                // *** End programmer edit section *** (записьвнакладной.количество Set end)
            }
        }
        
        /// <summary>
        /// вес.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.вес CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.вес CustomAttributes)
        public virtual double вес
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.вес Get start)

                // *** End programmer edit section *** (записьвнакладной.вес Get start)
                double result = this.fвес;
                // *** Start programmer edit section *** (записьвнакладной.вес Get end)

                // *** End programmer edit section *** (записьвнакладной.вес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.вес Set start)

                // *** End programmer edit section *** (записьвнакладной.вес Set start)
                this.fвес = value;
                // *** Start programmer edit section *** (записьвнакладной.вес Set end)

                // *** End programmer edit section *** (записьвнакладной.вес Set end)
            }
        }
        
        /// <summary>
        /// цена.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.цена CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.цена CustomAttributes)
        public virtual double цена
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.цена Get start)

                // *** End programmer edit section *** (записьвнакладной.цена Get start)
                double result = this.fцена;
                // *** Start programmer edit section *** (записьвнакладной.цена Get end)

                // *** End programmer edit section *** (записьвнакладной.цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.цена Set start)

                // *** End programmer edit section *** (записьвнакладной.цена Set start)
                this.fцена = value;
                // *** Start programmer edit section *** (записьвнакладной.цена Set end)

                // *** End programmer edit section *** (записьвнакладной.цена Set end)
            }
        }
        
        /// <summary>
        /// сумма.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.сумма CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.сумма CustomAttributes)
        public virtual double сумма
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.сумма Get start)

                // *** End programmer edit section *** (записьвнакладной.сумма Get start)
                double result = this.fсумма;
                // *** Start programmer edit section *** (записьвнакладной.сумма Get end)

                // *** End programmer edit section *** (записьвнакладной.сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.сумма Set start)

                // *** End programmer edit section *** (записьвнакладной.сумма Set start)
                this.fсумма = value;
                // *** Start programmer edit section *** (записьвнакладной.сумма Set end)

                // *** End programmer edit section *** (записьвнакладной.сумма Set end)
            }
        }
        
        /// <summary>
        /// Записьвнакладной.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.Товар CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.Товар CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_склад.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.Товар Get start)

                // *** End programmer edit section *** (записьвнакладной.Товар Get start)
                IIS.АСУ_склад.Товар result = this.fТовар;
                // *** Start programmer edit section *** (записьвнакладной.Товар Get end)

                // *** End programmer edit section *** (записьвнакладной.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.Товар Set start)

                // *** End programmer edit section *** (записьвнакладной.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (записьвнакладной.Товар Set end)

                // *** End programmer edit section *** (записьвнакладной.Товар Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_склад.накладная.
        /// </summary>
        // *** Start programmer edit section *** (записьвнакладной.накладная CustomAttributes)

        // *** End programmer edit section *** (записьвнакладной.накладная CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.АСУ_склад.накладная накладная
        {
            get
            {
                // *** Start programmer edit section *** (записьвнакладной.накладная Get start)

                // *** End programmer edit section *** (записьвнакладной.накладная Get start)
                IIS.АСУ_склад.накладная result = this.fнакладная;
                // *** Start programmer edit section *** (записьвнакладной.накладная Get end)

                // *** End programmer edit section *** (записьвнакладной.накладная Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (записьвнакладной.накладная Set start)

                // *** End programmer edit section *** (записьвнакладной.накладная Set start)
                this.fнакладная = value;
                // *** Start programmer edit section *** (записьвнакладной.накладная Set end)

                // *** End programmer edit section *** (записьвнакладной.накладная Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "записьвнакладнойE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View записьвнакладнойE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("записьвнакладнойE", typeof(IIS.АСУ_склад.записьвнакладной));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of записьвнакладной.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfзаписьвнакладной CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfзаписьвнакладной CustomAttributes)
    public class DetailArrayOfзаписьвнакладной : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_склад.DetailArrayOfзаписьвнакладной members)

        // *** End programmer edit section *** (IIS.АСУ_склад.DetailArrayOfзаписьвнакладной members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type записьвнакладной by index.
        /// </summary>
        /// <summary>
        /// Adds object with type записьвнакладной.
        /// </summary>
        public DetailArrayOfзаписьвнакладной(IIS.АСУ_склад.накладная fнакладная) : 
                base(typeof(записьвнакладной), ((ICSSoft.STORMNET.DataObject)(fнакладная)))
        {
        }
        
        public IIS.АСУ_склад.записьвнакладной this[int index]
        {
            get
            {
                return ((IIS.АСУ_склад.записьвнакладной)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_склад.записьвнакладной dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
