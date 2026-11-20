using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_217_JA_09 : CardInfo
{
    public CardInfo_217_JA_09()
    {
        this.cardNo = "217_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アリス";
        this.cardName2 = "流されちゃった";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
