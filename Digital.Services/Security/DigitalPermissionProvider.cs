using System.Collections.Generic;
using System.Linq;
using Nop.Core.Domain.Security;
using Nop.Services.Security;

namespace Digital.Services.Security
{
    public class DigitalPermissionProvider: IPermissionProvider
    {
        public static readonly PermissionRecord ManageAllSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. All Settings",
            SystemName = "ManageSettings.AllSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageCatalogSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Catalog Settings",
            SystemName = "ManageSettings.CatalogSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageGeneralSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. General Settings",
            SystemName = "ManageSettings.GeneralSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManagecustomerSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Customer Settings",
            SystemName = "ManageSettings.CustomerSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageShoppingCartSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Shopping Cart Settings",
            SystemName = "ManageSettings.ShoppingCartSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageOrderSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Order Settings",
            SystemName = "ManageSettings.OrderSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageMediaSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Media Settings",
            SystemName = "ManageSettings.MediaSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageTaxSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Tax Settings",
            SystemName = "ManageSettings.TaxSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageShippingSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Shipping Settings",
            SystemName = "ManageSettings.ShippingSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageRewardPointsSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Reward Points Settings",
            SystemName = "ManageSettings.RewardPoints",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageBlogSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Blog Settings",
            SystemName = "ManageSettings.BlogSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageNewsSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. News Settings",
            SystemName = "ManageSettings.NewsSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageForumSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Forum Settings",
            SystemName = "ManageSettings.ForumSettings",
            Category = "Configuration"
        };

        public static readonly PermissionRecord ManageVendorSettings = new PermissionRecord
        {
            Name = "Admin area. Manage Settings. Vendor Settings",
            SystemName = "ManageSettings.VendorSettings",
            Category = "Configuration"
        };

        //public static readonly PermissionRecord ManageSettings = new PermissionRecord { Name = "Admin area. Manage Settings", SystemName = "ManageSettings", Category = "Configuration" };
        public IEnumerable<PermissionRecord> GetPermissions()
        {
            return new[]
            {
                ManageAllSettings, ManageBlogSettings, ManageCatalogSettings, ManageForumSettings, ManageGeneralSettings,
                ManageMediaSettings, ManageNewsSettings,
                ManageOrderSettings, ManageRewardPointsSettings, ManageShippingSettings, ManageShoppingCartSettings,
                ManageTaxSettings, ManageVendorSettings, ManagecustomerSettings
            };
        }

        public IEnumerable<DefaultPermissionRecord> GetDefaultPermissions()
        {
            return Enumerable.Empty<DefaultPermissionRecord>();
        }
    }
}