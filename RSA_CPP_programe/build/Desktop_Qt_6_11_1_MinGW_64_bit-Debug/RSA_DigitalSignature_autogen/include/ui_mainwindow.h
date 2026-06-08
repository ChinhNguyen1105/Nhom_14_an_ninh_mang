/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.11.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTabWidget>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QTabWidget *tabWidget;
    QWidget *tab_1;
    QLabel *label;
    QLineEdit *txtP;
    QLineEdit *txtQ;
    QLabel *label_2;
    QPushButton *btnGenerate;
    QTextEdit *txtKeyResult;
    QPushButton *btnSavePublic;
    QPushButton *btnSavePrivate;
    QPushButton *btnLoadPublic;
    QPushButton *btnLoadPrivate;
    QGroupBox *groupBox;
    QTextEdit *txtPublicInfo;
    QGroupBox *groupBox_2;
    QTextEdit *txtPrivateInfo;
    QPushButton *btnAutoGenerate;
    QWidget *tab2;
    QTextEdit *txtMessage;
    QPushButton *btnSign;
    QTextEdit *txtSignature;
    QLabel *label_5;
    QLabel *label_6;
    QTextEdit *txtSHA256;
    QLabel *label_7;
    QPushButton *btnOpenFile;
    QLineEdit *txtFilePath;
    QPushButton *btnSaveSignature;
    QWidget *widget;
    QTextEdit *txtVerifyMessage;
    QTextEdit *txtVerifySignature;
    QPushButton *btnVerify;
    QLabel *lblResult;
    QLabel *label_3;
    QLabel *label_4;
    QPushButton *btnLoadSignature;
    QPushButton *btnOpenVerifyFile;
    QLineEdit *txtVerifyFilePath;
    QTextEdit *txtVerifyHash;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(492, 600);
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        tabWidget = new QTabWidget(centralwidget);
        tabWidget->setObjectName("tabWidget");
        tabWidget->setGeometry(QRect(0, 0, 531, 561));
        tabWidget->setUsesScrollButtons(false);
        tab_1 = new QWidget();
        tab_1->setObjectName("tab_1");
        label = new QLabel(tab_1);
        label->setObjectName("label");
        label->setGeometry(QRect(10, 10, 37, 12));
        txtP = new QLineEdit(tab_1);
        txtP->setObjectName("txtP");
        txtP->setGeometry(QRect(30, 10, 321, 20));
        txtQ = new QLineEdit(tab_1);
        txtQ->setObjectName("txtQ");
        txtQ->setGeometry(QRect(30, 40, 321, 20));
        label_2 = new QLabel(tab_1);
        label_2->setObjectName("label_2");
        label_2->setGeometry(QRect(10, 40, 37, 12));
        btnGenerate = new QPushButton(tab_1);
        btnGenerate->setObjectName("btnGenerate");
        btnGenerate->setGeometry(QRect(30, 70, 161, 21));
        txtKeyResult = new QTextEdit(tab_1);
        txtKeyResult->setObjectName("txtKeyResult");
        txtKeyResult->setGeometry(QRect(30, 100, 321, 101));
        btnSavePublic = new QPushButton(tab_1);
        btnSavePublic->setObjectName("btnSavePublic");
        btnSavePublic->setGeometry(QRect(40, 310, 151, 21));
        btnSavePrivate = new QPushButton(tab_1);
        btnSavePrivate->setObjectName("btnSavePrivate");
        btnSavePrivate->setGeometry(QRect(40, 440, 151, 21));
        btnLoadPublic = new QPushButton(tab_1);
        btnLoadPublic->setObjectName("btnLoadPublic");
        btnLoadPublic->setGeometry(QRect(210, 310, 141, 21));
        btnLoadPrivate = new QPushButton(tab_1);
        btnLoadPrivate->setObjectName("btnLoadPrivate");
        btnLoadPrivate->setGeometry(QRect(210, 440, 141, 21));
        groupBox = new QGroupBox(tab_1);
        groupBox->setObjectName("groupBox");
        groupBox->setGeometry(QRect(30, 220, 331, 80));
        txtPublicInfo = new QTextEdit(groupBox);
        txtPublicInfo->setObjectName("txtPublicInfo");
        txtPublicInfo->setGeometry(QRect(10, 20, 311, 41));
        groupBox_2 = new QGroupBox(tab_1);
        groupBox_2->setObjectName("groupBox_2");
        groupBox_2->setGeometry(QRect(30, 350, 331, 81));
        txtPrivateInfo = new QTextEdit(groupBox_2);
        txtPrivateInfo->setObjectName("txtPrivateInfo");
        txtPrivateInfo->setGeometry(QRect(10, 20, 311, 41));
        btnAutoGenerate = new QPushButton(tab_1);
        btnAutoGenerate->setObjectName("btnAutoGenerate");
        btnAutoGenerate->setGeometry(QRect(200, 70, 151, 21));
        tabWidget->addTab(tab_1, QString());
        tab2 = new QWidget();
        tab2->setObjectName("tab2");
        txtMessage = new QTextEdit(tab2);
        txtMessage->setObjectName("txtMessage");
        txtMessage->setGeometry(QRect(30, 80, 301, 66));
        btnSign = new QPushButton(tab2);
        btnSign->setObjectName("btnSign");
        btnSign->setGeometry(QRect(30, 160, 111, 21));
        txtSignature = new QTextEdit(tab2);
        txtSignature->setObjectName("txtSignature");
        txtSignature->setGeometry(QRect(30, 220, 301, 66));
        label_5 = new QLabel(tab2);
        label_5->setObjectName("label_5");
        label_5->setGeometry(QRect(30, 190, 37, 20));
        label_6 = new QLabel(tab2);
        label_6->setObjectName("label_6");
        label_6->setGeometry(QRect(30, 60, 81, 16));
        txtSHA256 = new QTextEdit(tab2);
        txtSHA256->setObjectName("txtSHA256");
        txtSHA256->setGeometry(QRect(30, 320, 301, 66));
        label_7 = new QLabel(tab2);
        label_7->setObjectName("label_7");
        label_7->setGeometry(QRect(30, 300, 91, 16));
        btnOpenFile = new QPushButton(tab2);
        btnOpenFile->setObjectName("btnOpenFile");
        btnOpenFile->setGeometry(QRect(30, 30, 111, 21));
        txtFilePath = new QLineEdit(tab2);
        txtFilePath->setObjectName("txtFilePath");
        txtFilePath->setGeometry(QRect(170, 30, 161, 20));
        btnSaveSignature = new QPushButton(tab2);
        btnSaveSignature->setObjectName("btnSaveSignature");
        btnSaveSignature->setGeometry(QRect(180, 160, 111, 21));
        tabWidget->addTab(tab2, QString());
        widget = new QWidget();
        widget->setObjectName("widget");
        txtVerifyMessage = new QTextEdit(widget);
        txtVerifyMessage->setObjectName("txtVerifyMessage");
        txtVerifyMessage->setGeometry(QRect(20, 60, 301, 66));
        txtVerifySignature = new QTextEdit(widget);
        txtVerifySignature->setObjectName("txtVerifySignature");
        txtVerifySignature->setGeometry(QRect(20, 150, 301, 66));
        btnVerify = new QPushButton(widget);
        btnVerify->setObjectName("btnVerify");
        btnVerify->setGeometry(QRect(20, 230, 91, 21));
        lblResult = new QLabel(widget);
        lblResult->setObjectName("lblResult");
        lblResult->setGeometry(QRect(20, 260, 151, 16));
        label_3 = new QLabel(widget);
        label_3->setObjectName("label_3");
        label_3->setGeometry(QRect(20, 40, 71, 16));
        label_4 = new QLabel(widget);
        label_4->setObjectName("label_4");
        label_4->setGeometry(QRect(20, 130, 61, 16));
        btnLoadSignature = new QPushButton(widget);
        btnLoadSignature->setObjectName("btnLoadSignature");
        btnLoadSignature->setGeometry(QRect(140, 230, 101, 21));
        btnOpenVerifyFile = new QPushButton(widget);
        btnOpenVerifyFile->setObjectName("btnOpenVerifyFile");
        btnOpenVerifyFile->setGeometry(QRect(20, 10, 91, 21));
        txtVerifyFilePath = new QLineEdit(widget);
        txtVerifyFilePath->setObjectName("txtVerifyFilePath");
        txtVerifyFilePath->setGeometry(QRect(130, 10, 151, 20));
        txtVerifyHash = new QTextEdit(widget);
        txtVerifyHash->setObjectName("txtVerifyHash");
        txtVerifyHash->setGeometry(QRect(20, 300, 301, 66));
        tabWidget->addTab(widget, QString());
        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 492, 18));
        MainWindow->setMenuBar(menubar);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);

        retranslateUi(MainWindow);

        tabWidget->setCurrentIndex(0);


        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        label->setText(QCoreApplication::translate("MainWindow", "P:", nullptr));
        label_2->setText(QCoreApplication::translate("MainWindow", "Q:", nullptr));
        btnGenerate->setText(QCoreApplication::translate("MainWindow", "Sinh kho\314\201a ", nullptr));
        btnSavePublic->setText(QCoreApplication::translate("MainWindow", "L\306\260u Public Key", nullptr));
        btnSavePrivate->setText(QCoreApplication::translate("MainWindow", "L\306\260u Private Key", nullptr));
        btnLoadPublic->setText(QCoreApplication::translate("MainWindow", "\304\220o\314\243c Public Key", nullptr));
        btnLoadPrivate->setText(QCoreApplication::translate("MainWindow", "\304\220o\314\243c Private Key", nullptr));
        groupBox->setTitle(QCoreApplication::translate("MainWindow", "Public Key", nullptr));
        groupBox_2->setTitle(QCoreApplication::translate("MainWindow", " Private Key", nullptr));
        btnAutoGenerate->setText(QCoreApplication::translate("MainWindow", "Sinh kho\314\201a t\306\260\314\243 \304\221\303\264\314\243ng", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_1), QCoreApplication::translate("MainWindow", "Sinh kho\314\201a RSA", nullptr));
        btnSign->setText(QCoreApplication::translate("MainWindow", "K\303\275 s\341\273\221", nullptr));
        label_5->setText(QCoreApplication::translate("MainWindow", "Ch\306\260\314\203 ky\314\201 ", nullptr));
        label_6->setText(QCoreApplication::translate("MainWindow", "Th\303\264ng \304\221i\303\252\314\243p", nullptr));
        label_7->setText(QCoreApplication::translate("MainWindow", "SHA-256", nullptr));
        btnOpenFile->setText(QCoreApplication::translate("MainWindow", "Cho\314\243n file TXT", nullptr));
        btnSaveSignature->setText(QCoreApplication::translate("MainWindow", "L\306\260u ch\306\260\314\203 ky\314\201", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab2), QCoreApplication::translate("MainWindow", "Ky\314\201 s\303\264\314\201 ", nullptr));
        btnVerify->setText(QCoreApplication::translate("MainWindow", "Xa\314\201c minh ", nullptr));
        lblResult->setText(QCoreApplication::translate("MainWindow", "K\303\252\314\201t qua\314\211 ", nullptr));
        label_3->setText(QCoreApplication::translate("MainWindow", "Th\303\264ng \304\221i\303\252\314\243p", nullptr));
        label_4->setText(QCoreApplication::translate("MainWindow", "Ch\306\260\314\203 ky\314\201 ", nullptr));
        btnLoadSignature->setText(QCoreApplication::translate("MainWindow", "M\306\241\314\211 ch\306\260\314\203 ky\314\201 ", nullptr));
        btnOpenVerifyFile->setText(QCoreApplication::translate("MainWindow", "M\306\241\314\211 file TXT", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(widget), QCoreApplication::translate("MainWindow", "Xa\314\201c Minh ", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
