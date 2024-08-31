#include <furi.h>

#include <gui/gui.h>
#include <gui/elements.h>
#include <gui/view_dispatcher.h>

#include <gui/modules/submenu.h>
#include <gui/modules/variable_item_list.h>
#include <gui/modules/widget.h>

#include "flipperdeck_icons.h"
#include "assets_icons.h"

typedef struct {
    Gui* gui;
    ViewDispatcher* view_dispatcher;
    Submenu* main_submenu;
    VariableItemList* config_variable_item_list;
    Widget* about_widget;
} App;

typedef enum {
    AppViewMainSubmenu,
    AppViewConfig,
    AppViewAbout,
    AppViewWaitForConnection,
    AppViewPanel
} AppView;

const uint32_t selected_baud_rate = 9600;

/// Function prototypes

App* app_alloc();
void app_free(App* app);

void switch_to_view(void* context, uint32_t view_id);
uint32_t switch_to_main_menu_view(void* context);

/// Main submenu view functions
View* main_submenu_view_alloc(App* app);
