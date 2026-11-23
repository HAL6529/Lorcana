using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_11 : CardInfo
{
    public CardInfo_006_JA_11()
    {
        this.cardNo = "006_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ナコマ";
        this.cardName2 = "嵐が過ぎるのを待つ者";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolettaBaldariAndPatriBalanovsky;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
