import { EvolutionTemplatePage } from './app.po';

describe('Evolution App', function() {
  let page: EvolutionTemplatePage;

  beforeEach(() => {
    page = new EvolutionTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
