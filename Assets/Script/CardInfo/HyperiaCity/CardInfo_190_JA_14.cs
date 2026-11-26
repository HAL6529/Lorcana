using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_14 : CardInfo
{
    public CardInfo_190_JA_14()
    {
        this.cardNo = "190_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "エクター卿";
        this.cardName2 = "やかましい騎士";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HaJungSong;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
