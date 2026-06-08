#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "RSA.h"

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow() override;

private slots:
    void on_btnGenerate_clicked();

    void on_btnSign_clicked();

    void on_btnVerify_clicked();

    void on_btnSavePublic_clicked();

    void on_btnSavePrivate_clicked();

    void on_btnLoadPublic_clicked();

    void on_btnLoadPrivate_clicked();

    void on_btnOpenFile_clicked();

    void on_btnSaveSignature_clicked();

    void on_btnLoadSignature_clicked();

    void on_btnOpenVerifyFile_clicked();

    void on_btnAutoGenerate_clicked();

private:
    Ui::MainWindow *ui;

    RSA rsa;

    QString calculateHash(QString message);

    QString currentFilePath;

    QString verifyFilePath;
};
#endif // MAINWINDOW_H
