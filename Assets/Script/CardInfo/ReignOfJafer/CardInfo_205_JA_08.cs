using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_08 : CardInfo
{
    public CardInfo_205_JA_08()
    {
        this.cardNo = "205_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "レディ";
        this.cardName2 = "凛々しいお嬢さん";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
