#include "flipperdeck.h"

int32_t flipperdeck_app(void* p) {
    UNUSED(p);
    App* app = app_alloc();

    /// Main submenu view
    View* main_submenu_view = main_submenu_view_alloc(app);
    view_dispatcher_add_view(app->view_dispatcher, AppViewMainSubmenu, main_submenu_view);

    /// View dispatcher setup and run
    view_dispatcher_switch_to_view(app->view_dispatcher, AppViewMainSubmenu);
    view_dispatcher_run(app->view_dispatcher);

    /// Cleanup view dispatcher
    view_dispatcher_remove_view(app->view_dispatcher, AppViewMainSubmenu);

    /// Views freeing
    view_free(main_submenu_view);

    app_free(app);

    return 0;
}

App* app_alloc() {
    App* app = malloc(sizeof(App));

    app->view_dispatcher = view_dispatcher_alloc();
    app->main_submenu = submenu_alloc();
    app->config_variable_item_list = variable_item_list_alloc();
    app->about_widget = widget_alloc();

    app->gui = furi_record_open(RECORD_GUI);
    view_dispatcher_attach_to_gui(app->view_dispatcher, app->gui, ViewDispatcherTypeFullscreen);

    return app;
}
void app_free(App* app) {
    furi_record_close(RECORD_GUI);

    widget_free(app->about_widget);
    variable_item_list_free(app->config_variable_item_list);
    submenu_free(app->main_submenu);
    view_dispatcher_free(app->view_dispatcher);

    free(app);
}

void switch_to_view(void* context, uint32_t view_id) {
    App* app = context;
    view_dispatcher_switch_to_view(app->view_dispatcher, view_id);
}
uint32_t switch_to_main_menu_view(void* context) {
    UNUSED(context);
    return AppViewMainSubmenu;
}
static uint32_t view_exit_callback(void* context) {
    UNUSED(context);
    return VIEW_NONE;
}

/// Main submenu view functions
View* main_submenu_view_alloc(App* app) {
    submenu_reset(app->main_submenu);
    submenu_add_item(app->main_submenu, "Connect", AppViewWaitForConnection, switch_to_view, app);

    View* view = submenu_get_view(app->main_submenu);

    //view_set_context(view, app);
    view_set_previous_callback(view, view_exit_callback);

    return view;
}
