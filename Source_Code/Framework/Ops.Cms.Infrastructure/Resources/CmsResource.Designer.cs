﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.0
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtNet.Cms.Infrastructure.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CmsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CmsResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AtNet.Cms.Infrastructure.Resources.CmsResource", typeof(CmsResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;lang&gt;
        ///  &lt;item key=&quot;PAGE_NO_TAGS&quot; Zh_CN=&quot;无标签&quot; Zh_TW=&quot;无标签&quot; En_US=&quot;no tags&quot; Es=&quot;no tags&quot; Thai=&quot;ไม่มี แท็ก&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_PrePageText&quot; Zh_CN=&quot;上一页&quot; Zh_TW=&quot;上一頁&quot; En_US=&quot;Previous&quot; Es=&quot;Previous&quot; Thai=&quot;ก่อน&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_NextPageText&quot; Zh_CN=&quot;下一页&quot; Zh_TW=&quot;下一頁&quot; En_US=&quot;Next&quot; Es=&quot;Next&quot; Thai=&quot;ต่อไป&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_SelectPageText&quot; Zh_CN=&quot;选择页码：{0}页&quot; Zh_TW=&quot;選擇頁碼：{0}頁&quot; En_US=&quot;Select Page:{0}&quot; Es=&quot;Select Page:{0}&quot; Thai=&quot;ถัดไปเลือกหน้า:{0}&quot;/&gt;
        ///  &lt;item key=&quot;PAGE_P [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string lang_package {
            get {
                return ResourceManager.GetString("lang_package", resourceCulture);
            }
        }
    }
}
