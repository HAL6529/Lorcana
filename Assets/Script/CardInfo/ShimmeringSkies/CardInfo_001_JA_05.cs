using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_05 : CardInfo
{
    public CardInfo_001_JA_05()
    {
        this.cardNo = "001_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "コーダ";
        this.cardName2 = "おしゃべりな子グマ";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ThereseVildefall;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
