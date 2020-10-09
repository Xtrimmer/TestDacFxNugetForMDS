I just created a .NET Core app and tried to use DacFx to see which dll loaded.
It seems that it loaded the .NET Standard flavor of DacFx!
I inspected the object and is shows the right one.
So I am thinking that if we make AE packages netcoreapp then it will puck up the right DacFx dll.