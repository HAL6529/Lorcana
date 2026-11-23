using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_11 : CardInfo
{
    public CardInfo_048_JA_11()
    {
        this.cardNo = "048_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "雪花の収集家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Fairy};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
