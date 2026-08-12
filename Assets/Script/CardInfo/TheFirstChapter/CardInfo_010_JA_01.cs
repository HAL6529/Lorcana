using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_01 : CardInfo
{
    public CardInfo_010_JA_01()
    {
        this.cardNo = "010_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒ}ƒLƒVƒ}ƒX";
        this.cardName2 = "‹{“a‚Ì‹R”n";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Braian Weisz";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
