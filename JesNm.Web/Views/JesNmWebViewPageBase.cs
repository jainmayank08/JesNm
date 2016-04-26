using Abp.Web.Mvc.Views;

namespace JesNm.Web.Views
{
    public abstract class JesNmWebViewPageBase : JesNmWebViewPageBase<dynamic>
    {

    }

    public abstract class JesNmWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JesNmWebViewPageBase()
        {
            LocalizationSourceName = JesNmConsts.LocalizationSourceName;
        }
    }
}