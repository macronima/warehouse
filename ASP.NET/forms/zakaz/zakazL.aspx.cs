﻿/*flexberryautogenerated="true"*/
namespace IIS.АСУ_склад
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class заказL : BaseListForm<заказ>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public заказL() : base(заказ.Views.заказL)
        {
            EditPage = заказE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/zakaz/zakazL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
