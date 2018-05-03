import { CdlcWebPage } from './app.po';

describe('cdlc-web App', () => {
  let page: CdlcWebPage;

  beforeEach(() => {
    page = new CdlcWebPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
