using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_12 : CardInfo
{
    public CardInfo_012_JA_12()
    {
        this.cardNo = "012_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "モンタリー・ジャック";
        this.cardName2 = "チーズにメロメロ";
        this.power = 0;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.DiegoMachuca;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
