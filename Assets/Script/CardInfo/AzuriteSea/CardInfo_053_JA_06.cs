using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_06 : CardInfo
{
    public CardInfo_053_JA_06()
    {
        this.cardNo = "053_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ジーニー";
        this.cardName2 = "最高な最後の願い";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
