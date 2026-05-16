// LanguageSetting.cs

using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

internal class LanguageSetting
{
    public void ChangeLanguage(
        Form form,
        string cultureName) {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);

        Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);

        ApplyLanguage(form);
    }

    private void ApplyLanguage(Form form)
    {
        ComponentResourceManager resources = new ComponentResourceManager(form.GetType());

        ApplyControlResources(form, resources);
    }

    private void ApplyControlResources(
        Control control,
        ComponentResourceManager resources) {

        resources.ApplyResources(control, control.Name);

        foreach (Control child in control.Controls)
        {
            ApplyControlResources(child, resources);
        }
    }
}