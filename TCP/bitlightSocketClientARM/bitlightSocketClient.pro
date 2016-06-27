#-------------------------------------------------
#
# Project created by QtCreator 2016-05-24T17:21:30
#
#-------------------------------------------------

QT       += core gui network

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = bitlightSocketClient
TEMPLATE = app


SOURCES += main.cpp\
        widgetmain.cpp \
    splash.cpp \
    input/myinputpanelcontext.cpp \
    input/myinputpanel.cpp

HEADERS  += widgetmain.h \
    splash.h \
    input/myinputpanelcontext.h \
    input/myinputpanel.h

FORMS    += widgetmain.ui \
    splash.ui \
    input/myinputpanelform.ui
