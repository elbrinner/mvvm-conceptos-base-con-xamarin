using MvvmCross.Platform.WindowsCommon.Converters;
using MvvmCross.Plugins;
using MvvmCross.Plugins.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Visibility;

namespace MVVM.Uwp.Converters
{

    /// <summary>
    /// https://github.com/MvvmCross/MvvmCross-Tutorials/blob/master/ValueConversion/ValueConversion.UI.WP/NativeConverters/Bucket.cs
    /// </summary>
    /// <seealso cref="MvvmCross.Platform.WindowsCommon.Converters.MvxNativeValueConverter{MvvmCross.Plugins.Color.MvxNativeColorValueConverter}" />
    public class NativeColorConverter : MvxNativeValueConverter<MvxNativeColorValueConverter>
    {
    }

    public class RGBAValueConverter : MvxNativeValueConverter<MvxRGBAValueConverter>
    {

    }    

    public class NativeVisibilityConverter : MvxNativeValueConverter<MvxVisibilityValueConverter>
    {
    }
    public class NativeInvertedVisibilityConverter : MvxNativeValueConverter<MvxInvertedVisibilityValueConverter>
    {
    }

}
