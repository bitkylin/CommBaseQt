#ifndef SPLASH_H
#define SPLASH_H
#include "widgetmain.h"
#include <QWidget>

namespace Ui {
class splash;
}

class splash : public QWidget
{
    Q_OBJECT

public:
    explicit splash(QWidget *parent = 0);
    ~splash();

private slots:
    void on_btnTCPClient_clicked();

private:
    Ui::splash *ui;
    WidgetMain *widgetMain;
};

#endif // SPLASH_H
