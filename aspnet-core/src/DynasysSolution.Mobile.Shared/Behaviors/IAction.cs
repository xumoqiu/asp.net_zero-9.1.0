using Xamarin.Forms.Internals;

namespace DynasysSolution.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}