using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_08 : CardInfo
{
    public CardInfo_110_JA_08()
    {
        this.cardNo = "110_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マウイ";
        this.cardName2 = "しぶといトリックスター";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
