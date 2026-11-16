using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_06 : CardInfo
{
    public CardInfo_154_JA_06()
    {
        this.cardNo = "154_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヒロ・ハマダ";
        this.cardName2 = "チームリーダー";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
