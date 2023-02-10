using System;
using System.Windows;
using System.Windows.Input;

namespace LootButton;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        Money.Text = Settings.Default.Money + " ₽";
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void MinimizeApp_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void CloseApp_Click(object sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }

    private void Loot_Click(object sender, RoutedEventArgs e)
    {
        Money.Text = Convert.ToInt32(Money.Text.Replace("₽", "")) + 1 + " ₽";
        Settings.Default.Money = Convert.ToInt32(Money.Text.Replace("₽", ""));
        Settings.Default.Save();
    }
}