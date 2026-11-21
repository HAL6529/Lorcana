using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_09 : CardInfo
{
    public CardInfo_075_JA_09()
    {
        this.cardNo = "075_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マックス・グーフ";
        this.cardName2 = "反抗期のティーン";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RodrigoCamilo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
