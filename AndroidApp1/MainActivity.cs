namespace AndroidApp1;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        object? boolAsString = "FALSE";
        var toString = (boolAsString ?? false).ToString();

        using var view = this.FindViewById<TextView>(Resource.Id.textviewMain);
        view.Text = $"Value should be 'FALSE': {toString}";
    }
}
