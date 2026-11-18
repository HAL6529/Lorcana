using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_08 : CardInfo
{
    public CardInfo_087_JA_08()
    {
        this.cardNo = "087_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "トランプ";
        this.cardName2 = "注意深い番犬";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
