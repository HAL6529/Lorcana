using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_09 : CardInfo
{
    public CardInfo_074_JA_09()
    {
        this.cardNo = "074_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "冒険の始まりだ！";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> ();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
