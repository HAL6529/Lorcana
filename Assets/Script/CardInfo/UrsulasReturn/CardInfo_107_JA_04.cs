using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_04 : CardInfo
{
    public CardInfo_107_JA_04()
    {
        this.cardNo = "107_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "スーパーグーフ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
