using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_08 : CardInfo
{
    public CardInfo_085_JA_08()
    {
        this.cardNo = "085_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミセス・パッカード";
        this.cardName2 = "通信士";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AurelieLise_Anne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
