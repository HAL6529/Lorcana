using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_01 : CardInfo
{
    public CardInfo_048_JA_01()
    {
        this.cardNo = "048_JA_01";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "竜視眈々";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = "Grace Tran";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
