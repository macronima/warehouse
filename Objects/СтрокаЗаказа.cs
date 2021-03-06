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
    /// Строка заказа.
    /// </summary>
    // *** Start programmer edit section *** (СтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (СтрокаЗаказа CustomAttributes)
    [AutoAltered()]
    [Caption("Строка заказа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СтрокаЗаказаE", new string[] {
            "количество as \'Количество\'",
            "ценаСНалогами as \'Цена с налогами\'",
            "сумма as \'Сумма\'",
            "Товар as \'Товар\'",
            "Товар.название as \'Название\'"}, Hidden=new string[] {
            "Товар.название"})]
    [MasterViewDefineAttribute("СтрокаЗаказаE", "Товар", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "название")]
    public class СтрокаЗаказа : ICSSoft.STORMNET.DataObject
    {
        
        private int fколичество;
        
        private double fценаСНалогами;
        
        private double fсумма;
        
        private IIS.АСУ_склад.Товар fТовар;
        
        private IIS.АСУ_склад.заказ fзаказ;
        
        // *** Start programmer edit section *** (СтрокаЗаказа CustomMembers)

        // *** End programmer edit section *** (СтрокаЗаказа CustomMembers)

        
        /// <summary>
        /// количество.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.количество CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.количество CustomAttributes)
        public virtual int количество
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.количество Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.количество Get start)
                int result = this.fколичество;
                // *** Start programmer edit section *** (СтрокаЗаказа.количество Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.количество Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.количество Set start)
                this.fколичество = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.количество Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.количество Set end)
            }
        }
        
        /// <summary>
        /// ценаСНалогами.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.ценаСНалогами CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.ценаСНалогами CustomAttributes)
        public virtual double ценаСНалогами
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.ценаСНалогами Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.ценаСНалогами Get start)
                double result = this.fценаСНалогами;
                // *** Start programmer edit section *** (СтрокаЗаказа.ценаСНалогами Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.ценаСНалогами Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.ценаСНалогами Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.ценаСНалогами Set start)
                this.fценаСНалогами = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.ценаСНалогами Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.ценаСНалогами Set end)
            }
        }
        
        /// <summary>
        /// сумма.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.сумма CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.сумма CustomAttributes)
        public virtual double сумма
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.сумма Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.сумма Get start)
                double result = this.fсумма;
                // *** Start programmer edit section *** (СтрокаЗаказа.сумма Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.сумма Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.сумма Set start)
                this.fсумма = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.сумма Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.сумма Set end)
            }
        }
        
        /// <summary>
        /// Строка заказа.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Товар CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Товар CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_склад.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Get start)
                IIS.АСУ_склад.Товар result = this.fТовар;
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_склад.заказ.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.заказ CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.заказ CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.АСУ_склад.заказ заказ
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.заказ Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.заказ Get start)
                IIS.АСУ_склад.заказ result = this.fзаказ;
                // *** Start programmer edit section *** (СтрокаЗаказа.заказ Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.заказ Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.заказ Set start)
                this.fзаказ = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.заказ Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.заказ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СтрокаЗаказаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтрокаЗаказаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтрокаЗаказаE", typeof(IIS.АСУ_склад.СтрокаЗаказа));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of СтрокаЗаказа.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)
    public class DetailArrayOfСтрокаЗаказа : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_склад.DetailArrayOfСтрокаЗаказа members)

        // *** End programmer edit section *** (IIS.АСУ_склад.DetailArrayOfСтрокаЗаказа members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type СтрокаЗаказа by index.
        /// </summary>
        /// <summary>
        /// Adds object with type СтрокаЗаказа.
        /// </summary>
        public DetailArrayOfСтрокаЗаказа(IIS.АСУ_склад.заказ fзаказ) : 
                base(typeof(СтрокаЗаказа), ((ICSSoft.STORMNET.DataObject)(fзаказ)))
        {
        }
        
        public IIS.АСУ_склад.СтрокаЗаказа this[int index]
        {
            get
            {
                return ((IIS.АСУ_склад.СтрокаЗаказа)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_склад.СтрокаЗаказа dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
