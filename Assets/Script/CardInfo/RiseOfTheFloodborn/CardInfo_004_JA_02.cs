using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_02 : CardInfo
{
    public CardInfo_004_JA_02()
    {
        this.cardNo = "004_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "コブラ・バブルス";
        this.cardName2 = "ただの福祉局員ですよ";
        this.power = 5;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
