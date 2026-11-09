using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_03 : CardInfo
{
    public CardInfo_107_JA_03()
    {
        this.cardNo = "107_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒwƒCƒwƒC";
        this.cardName2 = "‚¢‚Â‚Ì‚Ü‚É‚©’TŒŸ‰Æ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
