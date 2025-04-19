using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using ex_sd.Entites;

namespace ex_sd;

public partial class MainWindow : Window
{
    public List<User> Users{get; set;}
    PostgresContext context;


    public MainWindow()
    {
        InitializeComponent();
        context = new PostgresContext();
        Users = context.Users.ToList();
        var usersListBox = this.FindControl<ListBox>("ListUsers");

        usersListBox.ItemsSource = Users;

    }
}