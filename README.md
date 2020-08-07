# learn-develop-app-that-queries-azure-sql

https://docs.microsoft.com/ja-jp/learn/modules/develop-app-that-queries-azure-sql/

## 環境

当リポジトリは ASP.NET Core Web は同じでランタイムを .NET Core 3.1 に変更しています。  

## 特記事項

* フォーマット作成時のコマンドに引数が足らないので解説の通りだとエラーになります。  

```bash
hosomi@Azure:~/educationdata$ bcp "$DATABASE_NAME.dbo.courses" format nul -c -f courses.fmt -t, -S "$DATABASE_SERVER.database.windows.net" -U $AZURE_USER -P $AZURE_PASSWORD
A valid table name is required for in, out, or format options.
```

次のように ``-d`` オプションを付与して発行します。  

```bash
bcp dbo.courses format nul -c -f courses.fmt -t, -S "$DATABASE_SERVER.database.windows.net" -U $AZURE_USER -P $AZURE_PASSWORD -d $DATABASE_NAME
```

取り込み処理のコマンドも同様に引数が足らないので付与してください。   