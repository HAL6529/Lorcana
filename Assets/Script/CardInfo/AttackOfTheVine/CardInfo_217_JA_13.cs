using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_217_JA_13 : CardInfo
{
    public CardInfo_217_JA_13()
    {
        this.cardNo = "217_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ランドール・ボッグス";
        this.cardName2 = "ねたみ深い同僚";
        this.power = 3;
        this.toughness = 1;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
