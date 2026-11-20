using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_09 : CardInfo
{
    public CardInfo_117_JA_09()
    {
        this.cardNo = "117_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パワーライン";
        this.cardName2 = "ミュージック・スーパースター";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
