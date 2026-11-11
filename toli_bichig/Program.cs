public namespacetoli_bichig()
{
    InitializeDatabase();
    InitializeUI();
    LoadWords();
    LoadSavedWords();
    RefreshSavedList(); // Энэ мөрийг нэмнэ
    RefreshGrid();
}