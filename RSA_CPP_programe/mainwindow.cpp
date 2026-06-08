#include "mainwindow.h"
#include "./ui_mainwindow.h"
#include <QCryptographicHash>
#include <QFile>
#include <QTextStream>
#include <QMessageBox>
#include <QFileDialog>
#include <QFile>
#include <QTextStream>
#include <QFileDialog>
#include <QFile>
#include <QTextStream>
#include <QFileDialog>
#include <QFile>
#include <QTextStream>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_btnGenerate_clicked()
{
    if(ui->txtP->text().isEmpty() ||
        ui->txtQ->text().isEmpty())
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Hay nhap P va Q");

        return;
    }
    long long p=
        ui->txtP->text().toLongLong();

    long long q=
        ui->txtQ->text().toLongLong();

    if(!rsa.isPrime(p))
    {
        QMessageBox::warning(
            this,
            "Loi",
            "P khong phai so nguyen to");

        return;
    }

    if(!rsa.isPrime(q))
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Q khong phai so nguyen to");

        return;
    }

    if(p == q)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "P va Q phai khac nhau");

        return;
    }

    rsa.generateKeys(p,q);

    QString publicInfo;

    publicInfo += "e = "
                  + QString::number(rsa.e);

    publicInfo += "\n";

    publicInfo += "n = "
                  + QString::number(rsa.n);

    ui->txtPublicInfo
        ->setText(publicInfo);

    QString privateInfo;

    privateInfo += "d = "
                   + QString::number(rsa.d);

    privateInfo += "\n";

    privateInfo += "n = "
                   + QString::number(rsa.n);

    ui->txtPrivateInfo
        ->setText(privateInfo);

    QString result;

    result+="n = "
              +QString::number(rsa.n);

    result+="\n";

    result+="e = "
              +QString::number(rsa.e);

    result+="\n";

    result+="d = "
              +QString::number(rsa.d);

    ui->txtKeyResult->setText(result);

}


void MainWindow::on_btnSign_clicked()
{
    if(rsa.n == 0)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Hay sinh khoa truoc");

        return;
    }

    if(ui->txtMessage->toPlainText().isEmpty())
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Hay nhap hoac mo file can ky");

        return;
    }

    QString msg =
        ui->txtMessage->toPlainText();

    QString hashString =
        calculateHash(msg);
    ui->txtSHA256
        ->setText(hashString);

    QString shortHash =
        hashString.left(8);

    bool ok;

    long long hash =
        shortHash.toLongLong(
            &ok,
            16);

    hash = hash % rsa.n;

    long long signature =
        rsa.sign(hash);

    ui->txtSignature
        ->setText(
            QString::number(signature));
    if(rsa.n == 0)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Vui long sinh khoa RSA truoc!");

        return;
    }
}


void MainWindow::on_btnVerify_clicked()
{
    QString msg =
        ui->txtVerifyMessage
            ->toPlainText();

    QString hashString =
        calculateHash(msg);
    ui->txtVerifyHash
        ->setText(hashString);


    QString shortHash =
        hashString.left(8);

    bool ok;

    long long hash =
        shortHash.toLongLong(
            &ok,
            16);

    hash = hash % rsa.n;

    long long signature =
        ui->txtVerifySignature
            ->toPlainText()
            .toLongLong();

    long long verifyHash =
        rsa.verify(signature);

    if(hash == verifyHash)
    {
        ui->lblResult
            ->setText(
                "Chu ky hop le");
    }
    else
    {
        ui->lblResult
            ->setText(
                "Chu ky khong hop le");
    }
    if(rsa.n == 0)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Chua co khoa RSA!");

        return;
    }
}

QString MainWindow::calculateHash(QString message)
{
    QByteArray hash =
        QCryptographicHash::hash(
            message.toUtf8(),
            QCryptographicHash::Sha256);

    return hash.toHex();
}



void MainWindow::on_btnSavePublic_clicked()
{
    if(rsa.n == 0)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Hay sinh khoa truoc!");

        return;
    }
    QFile file("public.key");

    if(file.open(QIODevice::WriteOnly))
    {
        QTextStream out(&file);

        out << rsa.e << "\n";
        out << rsa.n << "\n";

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da luu public.key");
    }

}


void MainWindow::on_btnSavePrivate_clicked()
{
    if(rsa.n == 0)
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Hay sinh khoa truoc!");

        return;
    }

    QFile file("private.key");

    if(file.open(QIODevice::WriteOnly))
    {
        QTextStream out(&file);

        out << rsa.d << "\n";
        out << rsa.n << "\n";

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da luu private.key");
    }
}


void MainWindow::on_btnLoadPublic_clicked()
{
    QString fileName =
        QFileDialog::getOpenFileName(
            this,
            "Mo Public Key",
            "",
            "Key Files (*.key)");

    if(fileName.isEmpty())
        return;

    QFile file(fileName);

    if(file.open(QIODevice::ReadOnly))
    {
        QTextStream in(&file);

        in >> rsa.e;
        in >> rsa.n;

        QString publicInfo;

        publicInfo += "e = "
                      + QString::number(rsa.e);

        publicInfo += "\n";

        publicInfo += "n = "
                      + QString::number(rsa.n);

        ui->txtPublicInfo
            ->setText(publicInfo);

        QString result;

        result += "e = "
                  + QString::number(rsa.e);

        result += "\n";

        result += "n = "
                  + QString::number(rsa.n);

        ui->txtKeyResult->setText(result);

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da nap Public Key");
    }
}


void MainWindow::on_btnLoadPrivate_clicked()
{
    QString fileName =
        QFileDialog::getOpenFileName(
            this,
            "Mo Private Key",
            "",
            "Key Files (*.key)");

    if(fileName.isEmpty())
        return;

    QFile file(fileName);

    if(file.open(QIODevice::ReadOnly))
    {
        QTextStream in(&file);

        in >> rsa.d;
        in >> rsa.n;

        QString privateInfo;

        privateInfo += "d = "
                       + QString::number(rsa.d);

        privateInfo += "\n";

        privateInfo += "n = "
                       + QString::number(rsa.n);

        ui->txtPrivateInfo
            ->setText(privateInfo);

        QString result;

        result += "d = "
                  + QString::number(rsa.d);

        result += "\n";

        result += "n = "
                  + QString::number(rsa.n);

        ui->txtKeyResult->setText(result);

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da nap Private Key");
    }
}


void MainWindow::on_btnOpenFile_clicked()
{
    QString fileName =
        QFileDialog::getOpenFileName(
            this,
            "Chon file",
            "",
            "Text Files (*.txt)");

    if(fileName.isEmpty())
        return;

    currentFilePath = fileName;

    ui->txtFilePath->setText(fileName);

    QFile file(fileName);

    if(file.open(QIODevice::ReadOnly))
    {
        QString content =
            file.readAll();

        ui->txtMessage->setText(content);

        file.close();
    }
}


void MainWindow::on_btnSaveSignature_clicked()
{
    if(ui->txtSignature->toPlainText().isEmpty())
    {
        QMessageBox::warning(
            this,
            "Loi",
            "Chua co chu ky de luu");

        return;
    }

    QString fileName =
        QFileDialog::getSaveFileName(
            this,
            "Luu chu ky",
            "",
            "Signature Files (*.sig)");

    if(fileName.isEmpty())
        return;

    QFile file(fileName);

    if(file.open(QIODevice::WriteOnly))
    {
        QTextStream out(&file);

        out << ui->txtSignature
                   ->toPlainText();

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da luu chu ky");
    }
}


void MainWindow::on_btnLoadSignature_clicked()
{
    QString fileName =
        QFileDialog::getOpenFileName(
            this,
            "Mo chu ky",
            "",
            "Signature Files (*.sig)");

    if(fileName.isEmpty())
        return;

    QFile file(fileName);

    if(file.open(QIODevice::ReadOnly))
    {
        QString signature =
            file.readAll();

        ui->txtVerifySignature
            ->setText(signature);

        file.close();

        QMessageBox::information(
            this,
            "Thanh cong",
            "Da nap chu ky");
    }
}


void MainWindow::on_btnOpenVerifyFile_clicked()
{
    QString fileName =
        QFileDialog::getOpenFileName(
            this,
            "Mo file can xac minh",
            "",
            "Text Files (*.txt)");

    if(fileName.isEmpty())
        return;

    verifyFilePath = fileName;

    ui->txtVerifyFilePath
        ->setText(fileName);

    QFile file(fileName);

    if(file.open(QIODevice::ReadOnly))
    {
        QString content =
            file.readAll();

        ui->txtVerifyMessage
            ->setText(content);

        file.close();
    }
}


void MainWindow::on_btnAutoGenerate_clicked()
{
    srand(time(NULL));

    long long p =
        rsa.generatePrime();

    long long q =
        rsa.generatePrime();

    while(p == q)
    {
        q = rsa.generatePrime();
    }

    ui->txtP->setText(
        QString::number(p));

    ui->txtQ->setText(
        QString::number(q));

    rsa.generateKeys(p,q);

    QString publicInfo;

    publicInfo += "e = "
                  + QString::number(rsa.e);

    publicInfo += "\n";

    publicInfo += "n = "
                  + QString::number(rsa.n);

    ui->txtPublicInfo
        ->setText(publicInfo);

    QString privateInfo;

    privateInfo += "d = "
                   + QString::number(rsa.d);

    privateInfo += "\n";

    privateInfo += "n = "
                   + QString::number(rsa.n);

    ui->txtPrivateInfo
        ->setText(privateInfo);
}

