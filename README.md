Usage of the Facebook CAPI library
==================================

* Setup the FacebookToken and FacebookPixelId values in App.config.
* There is an Adapter class FacebookDataConverter which converts the data attributes into Facebook format.
* Usage of the Library is as follows,

FacebookEvent ev = FacebookDataConverter.parseItemData(item);

if (ev != null)
{
	FacebookEventRequest eventRequest = new FacebookEventRequest(facebookPixelId, fbc);
        eventRequest.addEventItem(ev);
        eventRequest.execute();
}

* Facebook is going to make client_user_agent, action_source, and event_source_url mandatory for all requests. Ref: https://developers.facebook.com/docs/marketing-api/conversions-api/
* Currently the libaray sets the action_source as website by default, users can override this setting by having an action_source property on model class and setting it to another value.
