using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_02 : CardInfo
{
    public CardInfo_074_JA_02()
    {
        this.cardNo = "074_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "チェシャ猫";
        this.cardName2 = "ニヤニヤニャーニャー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
