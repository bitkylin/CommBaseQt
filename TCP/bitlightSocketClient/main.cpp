#include "splash.h"
#include <QApplication>
//#include"./input/myinputpanelcontext.h"
//#include<QTextCodec>
//#include"QWSServer"

int main(int argc, char *argv[])
{

    QApplication a(argc, argv);


//    QTextCodec::setCodecForLocale(QTextCodec::codecForName("UTF-8"));
//    QTextCodec::setCodecForCStrings(QTextCodec::codecForName("UTF-8"));
//    QTextCodec::setCodecForTr(QTextCodec::codecForName("UTF-8"));
//    QFont font=QFont("wenquanyi",120,50,false);
//    a.setFont(font);
//    MyInputPanelContext *ic = new MyInputPanelContext;
//    a.setInputContext(ic);
//    QWSServer::setCursorVisible(false);
    splash w;
    w.show();
    return a.exec();
}
