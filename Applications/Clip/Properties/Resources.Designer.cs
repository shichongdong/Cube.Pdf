﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cube.Pdf.App.Clip.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cube.Pdf.App.Clip.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   すべてのファイル (*.*)|*.* に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AttachFilter {
            get {
                return ResourceManager.GetString("AttachFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付するファイルを選択して下さい。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AttachTitle {
            get {
                return ResourceManager.GetString("AttachTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付状況 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ColumnCondition {
            get {
                return ResourceManager.GetString("ColumnCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   サイズ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ColumnLength {
            get {
                return ResourceManager.GetString("ColumnLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ファイル名 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ColumnName {
            get {
                return ResourceManager.GetString("ColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付済 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ConditionEmbedded {
            get {
                return ResourceManager.GetString("ConditionEmbedded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   新規 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ConditionNew {
            get {
                return ResourceManager.GetString("ConditionNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap HeaderImage {
            get {
                object obj = ResourceManager.GetObject("HeaderImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   PDF ファイル (*.pdf)|*.pdf;*.PDF|すべてのファイル (*.*)|*.* に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SourceFilter {
            get {
                return ResourceManager.GetString("SourceFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付対象となる PDF ファイルを選択して下さい。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SourceTitle {
            get {
                return ResourceManager.GetString("SourceTitle", resourceCulture);
            }
        }
    }
}
